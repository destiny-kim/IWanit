const config = require('../../config/config.json');
const nodemailer = require('nodemailer');

const nodeMailer = {
    sendMail: (mailParameters) => {
        const transporter = nodemailer.createTransport({
            service: 'gmail',
            host: 'smtp.gmail.com',
            port: 587,
            secure: false,
            auth: {
              user: config.development.nodemailer.senderID,
              pass: config.development.nodemailer.senderPWD
            },
        });
        
        const mailOptions = {
            from: mailParameters.sender,
            to: mailParameters.receiver,
            subject: mailParameters.subject,
            text: mailParameters.content
        };
        
        transporter.sendMail(mailOptions, (nodemailerError, info) => {
            if (nodemailerError) {
                console.log('nodemailer occured error: ' + nodemailerError);
            } else {
                console.log('nodemailer sent: ' + info.response);
            }
        });        
    }
};

module.exports = nodeMailer;