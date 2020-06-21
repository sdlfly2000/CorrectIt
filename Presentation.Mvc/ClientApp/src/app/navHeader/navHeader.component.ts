import { Component, Input} from '@angular/core';

@Component({
  selector: 'navHeader',
  templateUrl: './navHeader.component.html',
  styleUrls:['./navHeader.component.css']
})
export class NavHeaderComponent {

  @Input() breadcrumbs: string[];

  constructor() {

  }

}
