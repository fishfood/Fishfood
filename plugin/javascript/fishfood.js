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

$(document).ready(function () {
    $("#settings").click(function () {
        if($('div.config').height() == 0){
            $('div.config').animate({ height: '300px' }, "slow");
        }
        else
            $('div.config').animate({ height: '0' }, "slow");
    });
});