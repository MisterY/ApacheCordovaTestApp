/**
 * Notifications
 */
angular.module("notifications", ["ionic"])

.run(function ($ionicPlatform) {
    $ionicPlatform.ready(function () {

        // Schedule notification for tomorrow to remember about the meeting
        cordova.plugins.notification.local.schedule({
            id: 10,
            title: "test!",
            text: "wake up",
            at: "sometimes",
            data: { meetingId: "123" }
        });

        // Join BBM Meeting when user has clicked on the notification 
        cordova.plugins.notification.local.on("click", function (notification) {
            if (notification.id == 10) {
                // joinMeeting(notification.data.meetingId);
                alert("yo! join the meeting");
            }
        });

        // Notification has reached its trigger time (Tomorrow at 8:45 AM)
        cordova.plugins.notification.local.on("trigger", function (notification) {
            if (notification.id !== 10)
                return;

            // After 10 minutes update notification's title 
            setTimeout(function () {
                cordova.plugins.notification.local.update({
                    id: 10,
                    title: "Meeting in 5 minutes!"
                });
            }, 3);
        });
    });
})
