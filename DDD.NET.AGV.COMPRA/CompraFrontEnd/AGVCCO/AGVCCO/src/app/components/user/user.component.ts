import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/users/user.service';
import { ActivatedRoute, Router } from '@angular/router';
import { User } from '../../models/user/user';
import { RequestResponse } from '../../models/common/request-response';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css'],
  providers: [UserService]
})
export class UserComponent implements OnInit {

  constructor(private userService: UserService, private router: Router, private rutaActiva: ActivatedRoute) { }
  user: User;
  requestResponse: RequestResponse;

  ngOnInit() {
    this.GetUser();
  }
  /**
   * Obtener usuario
   */
  GetUser() {
    /*console.log('Inica llamado al servicio User');*/
      this.userService.GetUser().subscribe(result => {
      this.requestResponse = result as RequestResponse;
      this.user = this.requestResponse.Result as User;
      console.log(this.user);
    // tslint:disable-next-line: no-shadowed-variable
    }, error => console.error(error));
  }
}
