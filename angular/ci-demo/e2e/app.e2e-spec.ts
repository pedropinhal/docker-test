import { CiDemoPage } from './app.po';

describe('ci-demo App', () => {
  let page: CiDemoPage;

  beforeEach(() => {
    page = new CiDemoPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
