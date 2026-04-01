import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {FormsModule} from '@angular/forms';
import {VehicleService } from '../../../../core/services/vehicle.service'

@Component({
  selector: 'app-vehicle-search',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './vehicle-search.html',
  styleUrls: ['./vehicle-search.css']
})
export class VehicleSearchComponent {
  makes: any[] = [];
  vehicleTypes: any[] = [];
  models: any[] = [];

  selectedMakeId!: number;
  year!: number;

  searchTerm: string = '';
  filteredMakes: any[] = [];

  constructor(private vehicleService : VehicleService ){}

  ngOnInit(){
    this.vehicleService.getMakes().subscribe(res => {
      this.makes = res;
      this.filteredMakes = this.makes;
    });
  }

  filterMakes() {
  const term = this.searchTerm.toLowerCase();

  this.filteredMakes = this.makes.filter(m =>
    m.name.toLowerCase().includes(term)
  );
}

  onSearch(){
    if (!this.selectedMakeId || !this.year || this.year < 1900) return;

    this.vehicleService.getVehicleTypes(this.selectedMakeId)
    .subscribe(res => this.vehicleTypes = res);

    this.vehicleService.getModels(this.selectedMakeId, this.year)
    .subscribe(res=> this.models = res);

  }
}
