const express = require('express');
const router = express.Router();
const controller = require('./UserController');
const passport = require('./passport');

router.post('/SignUp', controller.SignUp);
router.post('/SignIn',
    passport.authenticate(
        'local', 
        { 
            successRedirect: '/Baby/LoadBabyInfo',
            failureRedirect: '/User/FailedSignIn',
            failureFlash: false
        }
    )
);
router.get('/FailedSignIn', controller.FailedSignIn);
router.get('/SignOut', controller.SignOut);
router.post('/UpdatePWD', controller.UpdatePWD);
router.post('/FindID', controller.FindID);
router.post('/FindPWD', controller.FindPWD);
router.get('/SendEmail', controller.SendEmail);
router.get('/DeleteUser', controller.DeleteUser);

module.exports = router;