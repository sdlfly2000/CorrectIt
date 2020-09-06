import { NgModule } from '@angular/core';

import { NzLayoutModule } from 'ng-zorro-antd/layout';
import { NzMenuModule } from 'ng-zorro-antd/menu';
import { NzTableModule } from 'ng-zorro-antd/table';
import { NzBreadCrumbModule } from 'ng-zorro-antd/breadcrumb';
import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzIconModule } from 'ng-zorro-antd/icon';
import { NzFormModule } from 'ng-zorro-antd/form';

@NgModule({
  exports: [
    NzLayoutModule,
    NzMenuModule,
    NzTableModule,
    NzBreadCrumbModule,
    NzButtonModule,
    NzIconModule,
    NzFormModule]
})
export class NgZorroModule { }
