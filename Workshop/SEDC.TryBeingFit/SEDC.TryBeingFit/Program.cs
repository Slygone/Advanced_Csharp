using SEDC.TryBeingFit.Services;
//login

//1. enter username and password
//2. validate username and password are not empty
//3. search for a user with this username and password
//4. set flag to logged in or keep in a variable the found user


//get all video trainings
//for example, the end user chose an option to see all the video trainings



VideoTrainingService videoTrainingService = new VideoTrainingService();
var videos = videoTrainingService.GetAllVideoTrainings();