var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('BookLending');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);