const mongoose = require ('mongoose');

const schemaJogo = new mongoose.Schema({
    time1: {
        required: true, 
        type: String
    },
    pontosTime1: {
        required: true, 
        type: String
    }, 
    time2: {
        required: true, 
        type: String
    },
    pontosTime2: {
        required: true,
        type: String
    }
}, 
    {
        versionKey: false
    }
)

module.exports = mongoose.model('copa', schemaJogo)