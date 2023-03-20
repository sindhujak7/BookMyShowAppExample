import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EnvService {
public API_URL:string;

  constructor() {

    
    this.API_URL= 'https://localhost:7067/api/'
   }
}
