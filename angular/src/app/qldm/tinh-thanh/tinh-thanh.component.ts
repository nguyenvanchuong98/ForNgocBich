import { Component, Injector, OnInit } from '@angular/core';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { TinhThanhDto, TinhThanhDtoPagedResultDto, TinhThanhServiceProxy } from '@shared/service-proxies/service-proxies';
import { result } from 'lodash-es';
import { BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs/operators';

class PagedTinhthanhsRequestDto extends PagedRequestDto {
  keyword: string;
}
@Component({
  selector: 'app-tinh-thanh',
  templateUrl: './tinh-thanh.component.html',
  styleUrls: ['./tinh-thanh.component.css']
})
export class TinhThanhComponent extends PagedListingComponentBase<TinhThanhDto> {
  tinhthanhs: TinhThanhDto[] = [];
  keyword = '';

  constructor(
    injector: Injector,
    private _tinhthanhService: TinhThanhServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector)
  }

  list(
    request: PagedTinhthanhsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;
    this._tinhthanhService
      .getAll(null)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: TinhThanhDtoPagedResultDto) => {
        this.tinhthanhs = result.items;
        this.showPaging(result, pageNumber);
        console.log(result.items);
        
      });
  }

  protected delete(entity: TinhThanhDto): void {
    throw new Error('Method not implemented.');
  }
}
