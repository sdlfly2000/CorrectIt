import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AppComponent } from './app.component';
import { QuestionComponent } from './mainPanel/Questions/questions.component';
import { QuestionDetailsComponent } from './mainPanel/QuestionDetails/questiondetails.component';
import { NavHeaderComponent } from './navHeader/navHeader.component';

import { AppRoutingModule } from './app-routing.module';
import { IconsProviderModule } from './icons-provider.module';

import { NgZorroModule } from './ngzorro.module';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NZ_I18N } from 'ng-zorro-antd/i18n';
import { en_US } from 'ng-zorro-antd/i18n';
import { registerLocaleData } from '@angular/common';
import en from '@angular/common/locales/en';

registerLocaleData(en);

@NgModule({
  declarations: [
    AppComponent,
    QuestionComponent,
    QuestionDetailsComponent,
    NavHeaderComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
    IconsProviderModule,
    BrowserAnimationsModule,
    NgZorroModule
  ],
  providers: [{ provide: NZ_I18N, useValue: en_US }],
  bootstrap: [AppComponent]
})
export class AppModule { }
