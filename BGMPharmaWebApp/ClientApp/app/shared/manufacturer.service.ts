import { Injectable } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Injectable()
export class ManufacturerService {
    constructor() { }

    form: FormGroup = new FormGroup({
        $id: new FormControl(null),
        name: new FormControl(''),
        address: new FormControl(''),
        district: new FormControl(''),
        state: new FormControl(''),
        phone: new FormControl(''),
        mobile: new FormControl(''),
        alternatePhone: new FormControl(''),
        postalCode: new FormControl(''),
        email: new FormControl('', Validators.email),
        website: new FormControl(''),
        description: new FormControl('')
    });
}