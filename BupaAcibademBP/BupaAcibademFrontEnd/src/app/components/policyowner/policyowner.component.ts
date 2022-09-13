import { Component, OnInit } from '@angular/core';
import { PolicyOwnerService } from 'src/app/services/policyowner/policyowner.service';

@Component({
  selector: 'app-policyowner',
  templateUrl: './policyowner.component.html',
  styleUrls: ['./policyowner.component.css']
})
export class PolicyownerComponent implements OnInit {

  constructor(public service:PolicyOwnerService) { }

  ngOnInit(): void {
  }

}
