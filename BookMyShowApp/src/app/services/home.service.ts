import { Injectable } from '@angular/core';
import {HttpClient ,HttpHeaders}   from  '@angular/common/http';
import { EnvService } from './env.service';
@Injectable({
  providedIn: 'root'
})
export class HomeService {
  public requestOptions:any;
  constructor(private http:HttpClient ,private env:EnvService) {
      const tokenvalue=localStorage.getItem('token');

          const headers = new HttpHeaders({
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${tokenvalue}`
          });

        this.requestOptions = { headers: headers };
       

   }

getCitiesList(){
  
  var result=this.http.get(this.env.API_URL+"Cities" ,this.requestOptions);
  
  return result;
}



}
