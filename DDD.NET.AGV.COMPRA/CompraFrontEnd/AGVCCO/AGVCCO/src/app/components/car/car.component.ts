import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Car } from '../../models/cars/car';
import { CarService } from 'src/app/services/cars/car.service';
import { RequestResponse } from '../../models/common/request-response';
import { UserService } from '../../services/users/user.service';
import { User } from 'src/app/models/user/user';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css'],
  providers: [CarService, UserService]
})
export class CarComponent implements OnInit {
 /**
  * Constructor
  * @param carService ;
  * @param router ;
  * @param rutaActiva;
  */
  constructor(private http: HttpClient, private carService: CarService, private router: Router, private rutaActiva: ActivatedRoute) { }
  public requestResponse: RequestResponse;
  car: Car;
  user: User;
  ngOnInit() {
    /*this.GetCarAdd();*/
  }
/**
 * Obtener carrito adicionado
 */
  GetCarAdd() {
    this.carService.GetCarAdd('ADD', 999999).subscribe(result => {
      this.requestResponse = result as RequestResponse;
      this.car = this.requestResponse.Result as Car;
      console.log(this.car);
    // tslint:disable-next-line: no-shadowed-variable
    }, error => console.error(error));
  }

  /**
   *adicionar al carrito
   */
    AddCar() {
     console.log('Servicio de Car');
     this.carService.AddCar(this.car).subscribe(result => {
     this.requestResponse = result as RequestResponse;
     console.log(this.requestResponse);
     // tslint:disable-next-line: no-shadowed-variable
     }, error => console.error(error));
   }
  }
