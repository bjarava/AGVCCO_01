import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from '../../services/products/product.service';
import { Product } from '../../models/products/product';
import { RequestResponse } from '../../models/common/request-response';
import { CarService } from '../../services/cars/car.service';
import { UserService } from 'src/app/services/users/user.service';
import { User } from 'src/app/models/user/user';
import { Car } from 'src/app/models/cars/car';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  providers: [ProductService, CarService, UserService]
})
export class ProductComponent implements OnInit {
  /**
   * Constructor
   * @param productService ;
   * @param router;
   * @param rutaActiva;
   */
  constructor(private productService: ProductService, private router: Router, private rutaActiva: ActivatedRoute ) {

  }
  requestResponse: RequestResponse;
  product: Product;
  user: User;
  car: Car;
  carServices: CarService;

  public Listproduct: Product[];
  ngOnInit() {
    this.GetAllPro();
  }
  /**
   * Obtener lista de productos
   */
  GetAllPro() {
    /*console.log('Inica llamado al servicio GetAllPro');*/
      this.productService.GetAllPro().subscribe(result => {
      this.requestResponse = result as RequestResponse;
      this.product = this.requestResponse.Result as Product;
      console.log(this.product);
    // tslint:disable-next-line: no-shadowed-variable
    }, error => console.error(error));
  }
}

