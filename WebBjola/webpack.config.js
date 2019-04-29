var path = require('path');
var glob = require("glob");
var ExtractTextPlugin = require('extract-text-webpack-plugin');

module.exports = {
    mode: 'development',
    entry: {
        index: './Assets/js/index.js'
    },
    output: {
        filename: '[name].js',
        path: path.resolve(__dirname, 'wwwroot/js/')
    },
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: {
                    loader: "babel-loader"
                }
            },
            {
                test: /\.css$/,
                use: ExtractTextPlugin.extract({fallback: 'style-loader', use: ['css-loader']})
            }
        ]
    },
    plugins: [
        new ExtractTextPlugin('../css/[name].css')
    ]
};