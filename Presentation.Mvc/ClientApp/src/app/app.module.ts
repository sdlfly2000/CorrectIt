import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { QuestionComponent } from './mainPanel/Questions/questions.component';
import { TitleBarComponent } from './titleBar/titlebar.component';
import { NavBarComponent } from './navBar/navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    QuestionComponent,
    TitleBarComponent,
    NavBarComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: QuestionComponent, pathMatch: 'full' }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
