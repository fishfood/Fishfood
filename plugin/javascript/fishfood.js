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
	
	$('p.entry').click(function(){
			$('p.entry').animate({height:"300px"});
	});
	$('p.entry').click(function(){
		$('p.entry').animate({height:"0px"});
	});
	$('p.entry').animate({height:"300px"});
	$('div.config').animate({height:'300px',opacity:'0.4'},"slow");
}