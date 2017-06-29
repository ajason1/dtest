DeveloperTest = {};
DeveloperTest.PetListing = {};

$(function () {
    DeveloperTest.PetListing.GetPetListing = function () {
        $.ajax({
            url: "/api/petowners",
            datatype: "json",
            cache: false
        }).done(function (data, textStatus, jqXHR) {
            $.each(data, function (index, value) {
                var petList;
                petList = '<ul>' + value.OwnerGender;
                $.each(value.Pets, function (petIndex, petName) {
                    petList += '<li>' + petName.Name + '</li>';
                });
                petList += '</ul>'
                $(DeveloperTest.PetListing.Result).append(petList);
            });
        }).error(function (data, textStatus, jqXHR) {
            console.log(data);
        });
    }

    DeveloperTest.PetListing.GetPetListing();
});