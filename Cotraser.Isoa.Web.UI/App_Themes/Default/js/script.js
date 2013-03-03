$(document).ready(function() {
	// Fancybox setup
    $("a.js-fancybox").fancybox({
       openEffect: 'elastic',
       closeEffect: 'elastic'
    });
    //bootstrap tooltip setup
    //$('[rel="tooltip"]').tooltip();
});


window.onload = function () {
    var form = document.forms[0],
        inputs = form.elements;
    if (!Modernizr.input.autofocus) {
        inputs[0].focus();
    }

    if (!Modernizr.input.required) {
        form.onsubmit = function () {
            var required = [], att, val;
            for (var i = 0; i < inputs.length; i++) {
                att = inputs[i].getAttribute('required');
                if (att != null) {
                    val = inputs[i].value;
                    if (val.replace(/^\s+|\s+$/g, '') == '') {
                        required.push($(inputs[i]).attr("CustomName"));
                    }
                }
            }

            if (required.length > 0) {
                alert('Los siguientes campos son requeridos: ' +
                    required.join(', '));
                return false;
            }
        };
    }
}