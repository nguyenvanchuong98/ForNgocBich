import { Component, Injector, OnInit } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import {
  QuanHuyenServiceProxy,
  QuanHuyenDto,
  QuanHuyenDtoPagedResultDto,
} from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs/operators';

class PagedQuanhuyensRequestDto extends PagedRequestDto {
  keyword: string;
}
@Component({
  selector: 'app-quan-huyen',
  templateUrl: './quan-huyen.component.html',
  animations: [appModuleAnimation()],
  styleUrls: ['./quan-huyen.component.css']
})
export class QuanHuyenComponent extends PagedListingComponentBase<QuanHuyenDto> {

  quanhuyens: QuanHuyenDto[] = [];
  keyword = '';
  constructor(
    injector: Injector,
    private _quanhuyenService: QuanHuyenServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector)
  }

  list(
    request: PagedQuanhuyensRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;

    this._quanhuyenService
      .getAll(null)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: QuanHuyenDtoPagedResultDto) => {
        this.quanhuyens = result.items;
        this.showPaging(result, pageNumber);
      });
  }
  protected delete(entity: QuanHuyenDto): void {
    throw new Error('Method not implemented.');
  }
  // delete(quanhuyen: QuanHuyenDto): void {
  //   abp.message.confirm(
  //     this.l('QuanhuyenDeleteWarningMessage', quanhuyen.tenhuyen),
  //     undefined,
  //     (result: boolean) => {
  //       if (result) {
  //         this._quanhuyenService
  //           .delete(quanhuyen.id)
  //           .pipe(
  //             finalize(() => {
  //               abp.notify.success(this.l('SuccessfullyDeleted'));
  //               this.refresh();
  //             })
  //           )
  //           .subscribe(() => { });
  //       }
  //     }
  //   );
  // }

  // createQuanhuyen(): void {
  //   this.showCreateOrEditQuanhuyenDialog();
  // }

  // editQuanhuyen(quanhuyen: QuanHuyenDto): void {
  //   this.showCreateOrEditQuanhuyenDialog(quanhuyen.id);
  // }

  // showCreateOrEditQuanhuyenDialog(id?: number): void {
  //   let createOrEditQuanhuyenDialog: BsModalRef;
  //   if (!id) {
  //     createOrEditQuanhuyenDialog = this._modalService.show(
  //       CreateQuanhuyenDialogComponent,
  //       {
  //         class: 'modal-lg',
  //       }
  //     );
  //   } else {
  //     createOrEditQuanhuyenDialog = this._modalService.show(
  //       EditQuanhuyenDialogComponent,
  //       {
  //         class: 'modal-lg',
  //         initialState: {
  //           id: id,
  //         },
  //       }
  //     );
  //   }

  //   createOrEditQuanhuyenDialog.content.onSave.subscribe(() => {
  //     this.refresh();
  //   });
  // }
}
