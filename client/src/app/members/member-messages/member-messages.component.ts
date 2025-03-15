import { ChangeDetectionStrategy, ChangeDetectorRef, Component, Input, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Message } from 'src/app/_models/message';
import { MembersService } from 'src/app/_services/members.service';
import { MessageService } from 'src/app/_services/message.service';

@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-member-messages',
  templateUrl: './member-messages.component.html',
  styleUrls: ['./member-messages.component.css']
})
export class MemberMessagesComponent implements OnInit {
  @ViewChild('messageForm') messageForm: NgForm;
  @Input() messages: Message[];
  @Input() username: string;
  // @Input() loading: boolean;
  messageContent: string;
  // @Input() messageService: MessageService;



  // messageContent: string;
  // loading = false;

  constructor(private messageService: MessageService) { }

  ngOnInit(): void {

  }

  sendMessage() {

    this.messageService.sendMessage(this.username, this.messageContent).subscribe(message => {
      this.messages.push(message);
      this.messageForm.reset();
    });
    // this.loading = true;
    // this.messageService.sendMessage(this.username, this.messageContent).then(() => {
    //   this.messageForm.reset();
    // }).finally(() => this.loading = false);
  }


}