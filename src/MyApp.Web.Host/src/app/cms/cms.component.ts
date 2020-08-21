import { Component, OnInit, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import {
    PagedListingComponentBase,
    PagedRequestDto
} from 'shared/paged-listing-component-base';
import {
    CMSServiceProxy,
    CMSDto,
    PagedResultDtoOfCMSDto
} from '@shared/service-proxies/service-proxies';

class PagedCMSRequestDto extends PagedRequestDto {
    keyword: string;
    isActive: boolean | null;
}

@Component({
  selector: 'app-cms',
  templateUrl: './cms.component.html',
  styleUrls: ['./cms.component.css']
})
export class CmsComponent extends PagedListingComponentBase<CMSDto> {

    CMSPages: CMSDto[] = [];
    keyword = '';
    isActive: boolean | null;

    constructor(
        injector: Injector,
        private _cmsService: CMSServiceProxy
    ) {
        super(injector);
    }

    list(
        request: PagedCMSRequestDto,
        pageNumber: number,
        finishedCallback: Function
    ): void {

        request.keyword = this.keyword;
        request.isActive = this.isActive;

        this._cmsService
            .getAll(request.keyword, request.isActive, request.skipCount, request.maxResultCount)
            .pipe(
                finalize(() => {
                    finishedCallback();
                })
            )
            .subscribe((result: PagedResultDtoOfCMSDto) => {
                this.CMSPages = result.items;
                this.showPaging(result, pageNumber);
            });
    }

    delete(tenant: CMSDto): void {
        abp.message.confirm(
            this.l('TenantDeleteWarningMessage', this.CMSPages),
            (result: boolean) => {
                if (result) {
                    this._cmsService
                        .delete(tenant.id)
                        .pipe(
                            finalize(() => {
                                abp.notify.success(this.l('SuccessfullyDeleted'));
                                this.refresh();
                            })
                        )
                        .subscribe(() => { });
                }
            }
        );
    }

}
