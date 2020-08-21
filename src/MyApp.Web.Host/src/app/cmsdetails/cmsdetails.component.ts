import { Component, Injector, Optional, Inject, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AngularEditorConfig } from '@kolkov/angular-editor';
import {
    PagedListingComponentBase,
    PagedRequestDto
} from 'shared/paged-listing-component-base';
import {
    CMSServiceProxy,
    CMSDto,
    PagedResultDtoOfCMSDto
} from '@shared/service-proxies/service-proxies';
import { Observable } from 'rxjs';
import { AppComponentBase } from '@shared/app-component-base';
import { finalize } from 'rxjs/operators';
@Component({
  selector: 'app-cmsdetails',
  templateUrl: './cmsdetails.component.html',
  styleUrls: ['./cmsdetails.component.css']
})
export class CmsdetailsComponent extends AppComponentBase
implements OnInit {
    routerLocal: ActivatedRoute = null;
    pageData: CMSDto = new CMSDto();
    _cmsService: CMSServiceProxy = null;
    id;
    inedit: boolean | false;
    htmlContent: string = null;
    pageName: string = null;
    showComponent: boolean = true;

    constructor(injector: Injector,public router: ActivatedRoute, public proxy: CMSServiceProxy)
    {
        super(injector);
        this.routerLocal = router;
        this._cmsService = proxy;
        this.inedit = false;
    }
    ngOnInit() { 
        this.getPageData();
        
    }

    getPageData(): void {
        this.id = this.routerLocal.snapshot.paramMap.get("id");
        this._cmsService.get(this.id).subscribe(result => {
            this.pageData = result;
            this.htmlContent = this.pageData.data;
            this.pageName = this.pageData.pageName;
        });
        this.inedit = false;
    }

    editPage(id: number): void {
        this.inedit = true;
        //this.htmlcontent = this.pageData.data;
        console.log(this.htmlContent);


    }

    onCancelClick(index: number) {
        this.inedit = false;
        
    }

    refresh() {
        this.showComponent = false;
        setTimeout(x => this.showComponent = true);
    }

    onSaveClick(Id): boolean {
        //this.inedit = !this.inedit;
        let updatedData: CMSDto = new CMSDto();
        updatedData.pageName = this.pageName;
        updatedData.data = this.htmlContent;
        updatedData.id = this.id;
        console.log(updatedData);
        this._cmsService.update(updatedData).pipe(
            finalize(() => {
                this.inedit = false;
            })
        )
            .subscribe(() => {
                this.notify.info(this.l('SavedSuccessfully'));
            });
        this.refresh();
        return true;
    }


}
