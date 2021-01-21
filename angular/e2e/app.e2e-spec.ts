import { AspboilerTrainingTemplatePage } from './app.po';

describe('AspboilerTraining App', function() {
  let page: AspboilerTrainingTemplatePage;

  beforeEach(() => {
    page = new AspboilerTrainingTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
