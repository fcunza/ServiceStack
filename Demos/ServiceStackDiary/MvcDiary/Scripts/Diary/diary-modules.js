var dairyModule = {
    BindEvents: function () {
        $('#showRegisterForm').on('click', function () {
            $('#LoginFormContainer').hide('drop', function () {
                $('#RegisterFormContainer').show('drop');
            });            
        });
        $('#showLoginForm').on('click', function () {
            $('#RegisterFormContainer').hide('drop', function () {
                $('#LoginFormContainer').show('drop');
            });
        });
    }
};

$(function () {
    dairyModule.BindEvents();
});