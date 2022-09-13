import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CustomerModel } from 'src/app/models/customer-model.model';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http:HttpClient) { }
  readonly baseURL='https://localhost:44300/api/Customer/Add'
  formData:CustomerModel = new CustomerModel();
  list:CustomerModel[]

  postPaymentDetail(){
    return this.http.post(this.baseURL,this.formData)
  }

  refreshList(){
    this.http.get(this.baseURL)
    .toPromise()
    .then(res => this.list = res as CustomerModel[]);
  }
}
