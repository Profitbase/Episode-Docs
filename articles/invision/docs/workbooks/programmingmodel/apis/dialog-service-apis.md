# Dialog Service API

#### showConfirm

Displays a confirm dialog to the user, with the options to accept or reject. If the user accepts, `true` is returned, otherwise `false`. Note that the API is asynchronous and must be awaited like shown in the example below.  

```javascript
this.app.ui.dialogs.showConfirm({title: string, message: string, positiveButtonText?: string, negativeButtonText?: string }) : Promise<boolean>
this.app.ui.dialogs.showConfirm(text: string): Promise<boolean>
```

##### Example

```javascript
const result = await this.app.ui.dialogs.showConfirm({title: 'Delete customer', text: 'Are you sure you want to delete this customer?'});
if(result){
    await this.app.services.flow.execute("Delete Customer", {
        data: {
            customerId: this.app.variables._state.customerId
        }
    });
}
```

#### showMessage

Displays a message box to the user.

```javascript
this.app.ui.dialogs.showMessage({title: string, message: string, width?: number}) : void
this.app.ui.dialogs.showMessage(text: string): void
```

##### Example

```javascript
this.app.ui.dialogs.showMessage({title: 'Delete customer', text: 'The customer was deleted.'});
```

#### showChoice

Displays a popup to the user with multiple buttons and returns the option selected by the user. Note that the API is asynchronous and must be awaited.

```javascript
this.app.ui.dialogs.showChoice({title: string, text: string, width: number, height: number, options: { text: string; value: any }[]}) : Promise<any>
```

##### Example

```javascript
const response = await this.app.ui.dialogs.showChoice({title: 'Important choice', text: 'Is pineapple OK on pizza?', options: [{
        text: 'Yes',
        value: 1
    },{
        text: 'No',
        value: 2
    },{
        text: 'Maybe',
        value: 3
    }]
});

if(response === 3){
    this.app.ui.dialogs.showMessage(`Yup, it all depends on the other ingredients.`);
}else{
    this.app.ui.dialogs.showMessage(`You are ${response === 2 ? 'NOT' : ''} a pineapple lover.`);
}

```
