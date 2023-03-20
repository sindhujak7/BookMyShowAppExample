import { Component } from '@angular/core';
import { HomeService } from '../services/home.service';
import { NgModule } from '@angular/core';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import {MatCardModule}  from '@angular/material/card';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
public Cities:any=[];
decodedToken: any;
public selectedCityId:number=0;
  constructor( private homservice:HomeService ,private jwtHelper: JwtHelperService ,private  router:Router){

    this.IsTokenExpired();
   
  }
  


  getCitiesList(){
    this.homservice.getCitiesList().subscribe(data => 
      {
        
        this.Cities=data;
        this.selectedCityId = this.Cities[0].id;
      })
  }

  IsTokenExpired(){
     
    const tokenvalue=localStorage.getItem('token');
  
    if (this.jwtHelper.isTokenExpired(tokenvalue)) {
      
      console.log("token expired");
      this.RedirectLogin();
      // token expired 
    } else {
      console.log("token not expired");
      this.getCitiesList();
      // token valid
    }
  }
  RedirectLogin() {
    this.router.navigate(['login']);
  }
}
