import { Component, OnInit } from '@angular/core';
import { PolicyService } from 'src/app/services/policy/policy.service';

@Component({
  selector: 'app-policy',
  templateUrl: './policy.component.html',
  styleUrls: ['./policy.component.css']
})
export class PolicyComponent implements OnInit {

  constructor(public service:PolicyService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

}
