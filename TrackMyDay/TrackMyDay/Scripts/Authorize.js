$(document).ready(function () {
    getAccessToken();
    $("#btnGoogleLogin").click(function () {
        window.location.href = "/api/Account/ExternalLogin?provider=Google&response_type=token&client_id=self&redirect_uri=http%3A%2F%2Flocalhost%3A51057%2FLogin.html&state=3ZkQapfxTYdwqoqN2dUCW2eKiVBDVjLSQefFvcws7yU1";
       // window.location.href = "/api/Account/ExternalLogin?provider=Google&response_type=token&client_id=self&redirect_uri=http%3A%2F%2Flocalhost%3A51057%2F&state=3ZkQapfxTYdwqoqN2dUCW2eKiVBDVjLSQefFvcws7yU1";
    })
})

function getAccessToken() {

    if (location.hash) {
        if (location.hash.split('access_token=')) {
            var accessToken = location.hash.split("access_token=")[1].split("&")[0];
            IsUserRegistered(accessToken);
        }
    }
}

function IsUserRegistered(accessToken) {
    $.ajax({
        url: "/api/Account/UserInfo",
        method: "GET",
        headers: {
            'content-type': 'application/JSON',
            'Authorization': 'Bearer ' + accessToken
        },
        success: function (responsedata) {
            if (responsedata.HasRegistered) {
                localStorage.setItem("accesstoken", accessToken);
                localStorage.setItem("Username", responsedata.Email);
                $.ajax({
                    url: "/api/values",
                    method: "Get",
                    headers: {
                        'content-type': "application/JSON",
                        'Authorization': "Bearer " + accessToken
                    },
                    success: function (responsedata) {
                        alert(responsedata);
                    }
                })
            }
            else {
                RegisterExternalUser(accessToken);
            }
        }
    })
}

function RegisterExternalUser(accessToken) {
    $.ajax({
        method: "POST",
        url: "api/Account/RegisterExternal",
        headers: {
            'content-type': 'application/JSON',
            'authorization': 'Bearer ' + accessToken
        },
        success: function (responseData) {
            window.location.href = "/api/Account/ExternalLogin?provider=Google&response_type=token&client_id=self&redirect_uri=http%3A%2F%2Flocalhost%3A51057%2FLogin.html&state=3ZkQapfxTYdwqoqN2dUCW2eKiVBDVjLSQefFvcws7yU1";
           
        }

    })
}
