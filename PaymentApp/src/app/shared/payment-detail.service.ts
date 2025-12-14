import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { environment } from 'src/environments/environment';
import { PaymentDetail } from './payment-detail.model';
import { NgForm } from "@angular/forms";
declare global {
  interface Window { _env_: any; }
}
@Injectable({
  providedIn: 'root'
})

export class PaymentDetailService {

  url: string;
  list: PaymentDetail[] = [];
  formData: PaymentDetail = new PaymentDetail()
  formSubmitted: boolean = false;
  constructor(private http: HttpClient) { 
    const baseUrl = window._env_?.API_BASE_URL;
    this.url = `${baseUrl}/PaymentDetail`;
  }
  refreshList() {
    this.http.get(this.url)
      .subscribe({
        next: res => {
          this.list = res as PaymentDetail[]
        },
        error: err => { console.log(err) }
      })
  }

  postPaymentDetail() {
    return this.http.post(this.url, this.formData)
  }

  putPaymentDetail() {
    return this.http.put(this.url + '/' + this.formData.paymentDetailId, this.formData)
  }


  deletePaymentDetail(id: number) {
    return this.http.delete(this.url + '/' + id)
  }


  resetForm(form: NgForm) {
    form.form.reset()
    this.formData = new PaymentDetail()
    this.formSubmitted = false
  }
}
