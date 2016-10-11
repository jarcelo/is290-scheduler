$(document).ready(function () {
    $('#calendar').fullCalendar({
        theme: true,
        header: {
            left: '',
            center: '',
            right: ''
        },
        defaultView: 'agendaDay',
        editable: false,
        events: "/Calendar/GetEvents/"
    });
});