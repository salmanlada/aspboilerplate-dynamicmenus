import { MyAppTemplatePage } from './app.po';

describe('MyApp App', function() {
  let page: MyAppTemplatePage;

  beforeEach(() => {
    page = new MyAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
