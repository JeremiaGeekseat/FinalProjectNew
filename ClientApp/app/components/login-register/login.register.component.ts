import { Component } from '@angular/core';
import { User } from '../../data/user';

import { UserService } from '../../services/user.service';

@Component({
    selector: 'login-register',
    templateUrl: './login.register.component.html'
})
export class LoginRegisterComponent {
    regUser: User;

    constructor(private userService: UserService) { }

    register() {
        this.userService.register(this.regUser).then(() => this.regUser);
        this.regUser.email = '';
        this.regUser.name = '';
        this.regUser.password = '';
        this.regUser.phone = '';
        
    }

    ngOnInit() {
        this.regUser = new User(0, new Date(), new Date(), false, '', false, '', '', '', true);
    }
}
