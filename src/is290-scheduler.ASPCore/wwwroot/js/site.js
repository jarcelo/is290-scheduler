// Write your Javascript code.
$(document).ready(function () {
    $('#calendar').fullCalendar({
        theme: true,
        header: {
            left: 'prev, next, today',
            center: 'title',
            right: 'month, agendaWeek, agendaDay'
        },
        defaultView: 'agendaDay',
        editable: false,
        events: "/Calendar/GetEvents/"
    });
});