import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Policy } from 'src/app/models/policy.model';

@Injectable({
  providedIn: 'root'
})
export class PolicyService {

  readonly baseURL="https://localhost:44300/api/Policy/GetAll"
  formData:Policy = new Policy();
  list:Policy[]

  constructor(private http:HttpClient) { console.log(this.list)}

  refreshList(){
    this.http.get(this.baseURL)
    .toPromise()
    .then(res=> this.list = res as Policy[]);
  }
}
