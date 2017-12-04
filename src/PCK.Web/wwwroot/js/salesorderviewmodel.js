SalesOrderViewModel = function (data) {
    var self = this;
    ko.mapping.fromJS(data, {}, self);
    
    self.save = function () {

        //debugger;
        $.ajax({
            url: "/Sales/Save/",
            type: "POST",
            data: ko.toJSON(self),
            contentType: "application/json; charset=UTF-8",
            success: function (data) {
                console.log("postback data: " + data);
                if (data.salesOrderViewModel)
                    ko.mapping.fromJS(data.salesOrderViewModel, {}, self);
            }
        });
    }
};  