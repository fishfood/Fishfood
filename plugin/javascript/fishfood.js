function secondsInMilliseconds(numseconds)
{
   return numseconds * 1000;
}

function minutesInMilliseconds(numminutes)
{
  return secondsInMilliseconds(numminutes * 60);
}

function hoursInMilliseconds(numhours)
{
  return minutesInMilliseconds(numhours * 60);
}

function daysInMilliseconds(numdays)
{
  return hoursInMilliseconds(numdays * 24);
}

function yearsInMilliseconds(numyears)
{
  return daysInMilliseconds(numyears * 365);
}


function openConfig() {
    alert('confused.com');
}

function saveConfig() {
    $('.success').fadeIn('slow');
    $('div.config').animate({ height: '0' }, "slow");
    setTimeout(function () {
        $('.success').fadeOut('slow');
    }, 1000);
}

$(document).ready(function () {
    $('body').fireExtensionEvent('requestData');
    CrossriderAPI.bindExtensionEvent(document.body, 'receiveData', function (e, data) {
        // Verify that data was returned
        if (data) {
            // For this purpose of this demo, simply display the returned data to the user
            alert('Welcome back ' + data.username);
        }
    });
    $("#settings").click(function () {
        if($('div.config').height() == 0){
            $('div.config').animate({ height: '300px' }, "slow");
        }
        else
            $('div.config').animate({ height: '0' }, "slow");
    });
});