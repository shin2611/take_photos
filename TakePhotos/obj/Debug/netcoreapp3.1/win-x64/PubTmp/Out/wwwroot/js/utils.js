window.utils = {

    OverLay: function () {
        var html = '<div id="OverLay" style="width: 100%; height: 100%; left: 0; top: 0; position: fixed; z-index: 999992; background-color: black; opacity: 0.8"></div>';
        $("BODY").append(html);
    },

    RemoveOverLay: function () {
        $("#OverLay").remove();
    },

    AppendPopWrap: function (w, data) {

        var check = utils.checkMobile();
        var mrg = (100 - w) / 2;
        if (check) {
            w = 96;
            mrg = 2;
        }
        var html = '<div id="pop_wrap" style="position: fixed; top: 0; left: 0; z-index: 999998; width: ' + w + '%; margin-top: 4%; margin-left: ' + mrg + '%">';
        html += data + '</div>';

        $("BODY").append(html);
    },

    Loading: function () {
        var html = '<div id="loading_wrap" style="width: 100%; height: 100%; left: 0; top: 0; position: fixed; z-index: 999999;background-color: black; opacity: 0.9">';
        html += '<div style="top: 50%; left: 50%; position: absolute; transform: translate(-50%, -50%)">';
        html += '<img style="width:150px;" src="' + window.location.origin + '/assets/svg-loaders/bars.svg">';
        html += '</div></div>';

        $("BODY").append(html);
    },

    unLoading: function () {
        $("#loading_wrap").remove();
    },

    setCookie: function (cname, cvalue, exdays) {
        var d = new Date();
        d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
        var expires = "expires=" + d.toUTCString();
        document.cookie = cname + "=" + cvalue + "; " + expires + "; path=/";
    },

    getCookie: function (cname) {
        var name = cname + "=";
        var ca = document.cookie.split(';');
        for (var i = 0; i < ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) == ' ') c = c.substring(1);
            if (c.indexOf(name) == 0) return c.substring(name.length, c.length);
        }
        return "";
    },

    del_cookie: function (name) {
        document.cookie = name +
            '=; expires=Thu, 01-Jan-70 00:00:01 GMT;';
    },

    getLanguage: function () {
        var lang = utils.getCookie("languageJ") ? utils.getCookie('languageJ') : 0;
        var language = 0;
        try {
            language = parseInt(lang);
            if (language < 0 || language > 1)
                return 0;

            return language;
        }
        catch {
            return 0;
        }
    },

    formatNumber: function (num) {
        if (!num)
            return 0;

        if (Number(num) > -1000 && Number(num) < 1000)
            return num;

        return num.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,');
    },

    formatNumber2: function (num) {
        if (!num)
            return "";
        if (Number(num) > -1000 && Number(num) < 1000)
            return num;

        return num.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,');
    },

    formatDateInt: function (date) {
        if (!date) return "";
        date += '';

        var y = date.substring(0, 4);
        var m = date.substring(4, 6);
        var d = date.substring(6, 8);
        return d + "/" + m + "/" + y;
    },

    checkMobile: function () {

        if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
            return true;
        }

        return false;
    },

    GetOTPSMS: function () {
        utils.Loading();
        $.ajax({
            type: "POST",
            url: window.location.origin + '/home/GetOTPSMS',
            data: {
            },
            success: function (data) {
                utils.unLoading();
                bootbox.alert(data.message);
            },
            error: function () {
                utils.unLoading();
                self.mess = self.Noti.ServerError[self.language];
                bootbox.alert(self.mess);
            }
        });
    },

    GetOTPTelegram: function () {
        utils.Loading();
        $.ajax({
            type: "POST",
            url: window.location.origin + '/home/GetOTPTelegram',
            data: {
            },
            success: function (data) {
                utils.unLoading();
                bootbox.alert(data.message);
            },
            error: function () {
                utils.unLoading();
                self.mess = self.Noti.ServerError[self.language];
                bootbox.alert(self.mess);
            }
        });
    },

    readTextFile: function (file, callback) {
        var rawFile = new XMLHttpRequest();
        rawFile.overrideMimeType("application/json");
        rawFile.open("GET", file, true);
        rawFile.onreadystatechange = function () {
            if (rawFile.readyState === 4 && rawFile.status == "200") {
                callback(rawFile.responseText);
            }
        }
        rawFile.send(null);
    },

    //
    getDateTime: function (amount) {
        if (!amount) amount = 0;

        var today = new Date();
        var dayGet = new Date(today);
        dayGet.setDate(today.getDate() + amount);

        var month = '' + (dayGet.getMonth() + 1);
        var day = '' + dayGet.getDate();
        var year = dayGet.getFullYear();

        if (month.length < 2)
            month = '0' + month;
        if (day.length < 2)
            day = '0' + day;

        return [year, month, day].join('-');
    },

    getDateTimeInt: function (amount) {
        if (!amount) amount = 0;

        var today = new Date();
        var dayGet = new Date(today);
        dayGet.setDate(today.getDate() + amount);

        var month = '' + (dayGet.getMonth() + 1);
        var day = '' + dayGet.getDate();
        var year = dayGet.getFullYear();
        var hour = dayGet.getHours();
        var minute = dayGet.getMinutes();
        var second = dayGet.getSeconds();

        if (month.length < 2)
            month = '0' + month;
        if (day.length < 2)
            day = '0' + day;
        if (hour.length < 2)
            hour = '0' + hour;
        if (minute.length < 2)
            minute = '0' + minute;
        if (second.length < 2)
            second = '0' + second;

        return {
            datetime: [year, month, day, hour, minute, second].join(''),
            date: [year, month, day].join('')
        };
    },

    CheckOnlyNumber: function (obj, e) {
        var whichCode = (window.Event && e.which) ? e.which : e.keyCode; /*if (whichCode == 13) { this.onPlaceOrder(); return false; }*/
        if (whichCode == 9) return true;
        if ((whichCode >= 48 && whichCode <= 57) || whichCode == 8) {
            var n = obj.value.replace(/,/g, ""); if (whichCode == 8) {
                if (n.length != 0)
                    n = n.substr(0, n.length - 1);
            }
            if (parseFloat(n) == 0) {
                n = '';
            }
            return true;
        }
        e.returnValue = false; return false;
    },

    formateDateVue: function (date) {
        if (!date) return "";

        return moment(String(date)).format('YYYY-MM-DD');
    },

    formateDateVue2: function (date) {
        if (!date) return "";

        return moment(String(date)).format('YYYY-MM-DD HH:mm:ss');
    },

    AddDays: function (days, date) {
        var result = new Date(date);
        result.setDate(result.getDate() + days);
        return result;
    },

    getMonday: function (d) {
        d = new Date(d);
        var day = d.getDay(),
            diff = d.getDate() - day + (day == 0 ? -6 : 1); // adjust when day is sunday
        return new Date(d.setDate(diff));
    },

    getFirstLastDayOfMonth: function (datetime) {
        if (!datetime) datetime = new Date();

        var date = new Date(datetime), y = date.getFullYear(), m = date.getMonth();

        var firstDay = new Date(y, m, 1);
        var lastDay = new Date(y, m + 1, 0);

        firstDay = moment(firstDay).format('YYYY-MM-DD');
        lastDay = moment(lastDay).format('YYYY-MM-DD');

        return {
            firstDay: firstDay,
            lastDay: lastDay
        }
    },
}