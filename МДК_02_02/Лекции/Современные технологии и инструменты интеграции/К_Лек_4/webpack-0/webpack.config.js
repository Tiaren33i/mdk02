let path=require('path');

let conf={
	entry:'./src/index.js',
	output:{
		path:path.resolve(__dirname,'./dist'),
		filename:'main.js',
		publicPath:'dist/'
	},
	module: {
    rules: [
      {
        test: /\.(png|jpe?g|gif)$/i,
        loader: 'file-loader',
        options: {
          regExp: /\p{L}+(?=\.(png|jpe?g|gif)$)/gu,
          name(resourcePath, resourceQuery) {
            // `resourcePath` - `/absolute/path/to/file.js`
            // `resourceQuery` - `?foo=bar`

            if (process.env.NODE_ENV === 'development') {
              return '[path]';
            }
 
            return 'img/[0]/[ext]/_[hash].[ext]';
          },
        },
      },
    ],
  },
};
module.exports=conf;
