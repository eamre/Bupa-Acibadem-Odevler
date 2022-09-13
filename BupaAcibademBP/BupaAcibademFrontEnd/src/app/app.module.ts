import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CustomerComponent } from './components/customer/customer.component';
import { PolicyownerComponent } from './components/policyowner/policyowner.component';
import { CreditcardComponent } from './components/creditcard/creditcard.component';
import { PolicyComponent } from './components/policy/policy.component';
import { PrimComponent } from './components/prim/prim.component';

import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    CustomerComponent,
    PolicyownerComponent,
    CreditcardComponent,
    PolicyComponent,
    PrimComponent
  ],
  imports: [
    FormsModule,
    HttpClientModule,
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
