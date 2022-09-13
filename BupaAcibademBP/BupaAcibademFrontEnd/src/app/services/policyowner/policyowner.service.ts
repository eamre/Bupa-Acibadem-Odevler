import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PolicyOwnerModel } from 'src/app/models/policyowner-model.model';

@Injectable({
  providedIn: 'root'
})
export class PolicyOwnerService {

  constructor(private http:HttpClient) { }
  readonly baseURL='https://localhost:44300/api/PolicyOwner/Add'
  formData:PolicyOwnerModel = new PolicyOwnerModel();
  list:PolicyOwnerModel[]

}
