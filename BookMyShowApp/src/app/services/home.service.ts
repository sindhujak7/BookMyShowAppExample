import { Injectable } from '@angular/core';
import {HttpClient}   from  '@angular/common/http';
import { EnvService } from './env.service';
@Injectable({
  providedIn: 'root'
})
export class HomeService {

  constructor(private http:HttpClient ,private env:EnvService) { }

getCitiesList(){
  debugger
  var result=this.http.get(this.env.API_URL+"Cities");
  debugger
  return result;
}

}
