import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerComponent } from './components/customer/customer.component';
import { PolicyComponent } from './components/policy/policy.component';
import { PolicyownerComponent } from './components/policyowner/policyowner.component';

const routes: Routes = [
{path:'',component:PolicyownerComponent},
{path:'customer',component:CustomerComponent},
{path:'customer/policy',component:PolicyComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
