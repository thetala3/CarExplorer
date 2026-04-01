import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class VehicleService  {
  private baseUrl = 'http://localhost:5000/api/vehicles';
  constructor(private http: HttpClient){}

  getMakes(){
    return this.http.get<any[]>(`${this.baseUrl}/makes`);
  }

  getVehicleTypes(makeId: number){
    return this.http.get<any[]>(`${this.baseUrl}/vehicle-types?makeId=${makeId}`);
  }

  getModels(makeId: number, year: number){
    return this.http.get<any[]>(`${this.baseUrl}/models?makeId=${makeId}&year=${year}`);
  }
}
