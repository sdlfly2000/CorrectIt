import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public isCollapsed = false;
  public pBreadcrumbs: string[];

  constructor() {
    this.setBreadcrumb("Question Albums");
  }

  public onClickQuestionAlbums(router:string): void {
    this.setBreadcrumb(router);
  }

  private setBreadcrumb(router:string): void {
    this.pBreadcrumbs = [];
    this.pBreadcrumbs.push(router);
  }
}
