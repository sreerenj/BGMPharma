import { Component, Inject } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { HttpClient } from "@angular/common/http";
import { ManufacturerService } from "../../shared/manufacturer.service";

@Component({
    selector: "manufacturer",
    templateUrl: "./manufacturer.component.html",
    styleUrls: ["./manufacturer.component.css"]
})
export class ManufacturerComponent {
    manufacturer: Manufacturer;

    constructor(private activatedRoute: ActivatedRoute,
        private router: Router,
        private http: HttpClient,
        private service: ManufacturerService,
        @Inject('BASE_URL') private baseUrl: string) {

        this.manufacturer = <Manufacturer>{};
        var id = +this.activatedRoute.snapshot.params["id"];
        if (id) {
            var url = this.baseUrl + "api/manufacturer/" + id;

            this.http.get<Manufacturer>(url).subscribe(result => {
                    this.manufacturer = result;
                    console.log(this.manufacturer);
                },
                error => console.error(error));
        }
    }
} 