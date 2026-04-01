import { Component, signal } from '@angular/core';
import { VehicleSearchComponent } from './features/vehicles/pages/vehicle-search/vehicle-search.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [VehicleSearchComponent],
  template: `<app-vehicle-search></app-vehicle-search>`,
})
export class App {
  protected readonly title = signal('car-explorer-ui');
}