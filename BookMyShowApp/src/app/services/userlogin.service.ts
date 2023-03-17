import { Injectable } from '@angular/core';
import {HttpClient}   from  '@angular/common/http';
import { EnvService } from './env.service';
@Injectable({
  providedIn: 'root'
})
export class UserloginService {

  constructor(private http:HttpClient ,private env:EnvService) { }
  ProceedLogin(inputdata: any) {
    return this.http.post(this.env.API_URL+'Authentication/login', inputdata);
  }

  IsLoogedIn() {
   
    return localStorage.getItem('token') != null;
  }

  GetToken() {

    return localStorage.getItem('token') != null ? localStorage.getItem('token') : '';

  }

  Registeration(inputdata: any) {
    debugger
    return this.http.post(this.env.API_URL+'Authentication/register', inputdata);
  }

  
}
