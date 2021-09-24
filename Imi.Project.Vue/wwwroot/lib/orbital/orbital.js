var apiURL = 'https://gorest.co.in/public-api/users';
var app = new Vue({
    el: '#app',
    data: {
        users: null,
        currentUser: null
    },
    created: function () {
        var self = this;
        self.fetchUsers();
    },
    methods: {
        fetchUsers: function () {
            var self = this;
            axios.get(`${apiURL}`)
                .then(function (response) {
                    self.users = response.data.data;
                })
                .catch(function (error) {
                    console.error(error);
                });
        },
        getUserCssClass: function (user) {
            if (user.status == "Inactive") {
                return "list-group-item-danger";
            }
        },
        getUserDetails: function (user) {
            var self = this;
            self.currentUser = user;
        }
    }
});