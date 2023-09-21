function valid_datas( f ){
	
	if( f.name.value == '' ){
		jQuery('#form_status').html('<span class="wrong">Your name must not be empty!</span>');
		notice( f.name );
	}else if( f.email.value == '' ){
		jQuery('#form_status').html('<span class="wrong">Your email must not be empty and correct format!</span>');
		notice( f.email );
	}else if( f.subject.value == '' ){
		jQuery('#form_status').html('<span class="wrong">Your subject must not be empty!</span>');
		notice( f.subject );
	}else if( f.message.value == '' ){
		jQuery('#form_status').html('<span class="wrong">Your message must not be empty!</span>');
		notice( f.message );
	}else{
		return true
	}
	
	return false;
}

function valid_datas2( f ){
	if( f.name.value == '' ){
		jQuery('#form_status').html('<span class="wrong">Your name must not be empty!</span>');
		notice( f.name );
	}else if( f.email.value == '' ){
		jQuery('#form_status').html('<span class="wrong">Your email must not be empty and correct format!</span>');
		notice( f.email );
	}else if( f.phonenumber.value == '' ){
		jQuery('#form_status').html('<span class="wrong">Your phone must not be empty and correct format!</span>');
		notice( f.phonenumber );
	}else if( f.checkin.value == '' ){
		jQuery('#form_status').html('<span class="wrong">Enter check in and check out dates!</span>');
		notice( f.checkin );
	}else if( f.checkout.value == '' ){
		jQuery('#form_status').html('<span class="wrong">Enter check in and check out dates!</span>');
		notice( f.checkout );
	}else if( f.guests.value == '' ){
		jQuery('#form_status').html('<span class="wrong">Enter number of guests!</span>');
		notice( f.guests );
	}else{
		return true;
	}
	
	return false;
}

function notice( f ){
	jQuery('#fruitkha-contact').find('input,textarea').css('border','none');
	f.style.border = '1px solid red';
	f.focus();
}