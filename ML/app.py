from flask import Flask,render_template,url_for,request,jsonify
# import numpy as np 
import pandas as pd
df = pd.read_csv(r"D:/The thired year of fci/second term/term2/Machine-Learning-Web-Apps-master/Machine-Learning-Web-Apps-master/Nationality_n_Gender Predictor_ML-WebApp/data/Predicting_Nationality_Ethnicity_with_Names_Using_ML/Names_Dataset.csv")
print(df)
# ML Packages
from sklearn.externals import joblib

# from sklearn.feature_extraction.text import CountVectorizer
		# Load Our Count Vectorizer
gender_vectorizer = open("models/gender_vectorizer.pkl","rb")
gender_cv = joblib.load(gender_vectorizer)

	# Loading our ML Model
gender_nv_model = open("models/naivebayesgendermodel.pkl","rb")
gender_clf = joblib.load(gender_nv_model)

# Load Our Count Vectorizer
nationality_vectorizer = open("models/nationality_vectorizer.pkl","rb")
nationality_cv = joblib.load(nationality_vectorizer)

	# Loading our ML Model
nationality_nv_model = open("models/nationality_nv_model.pkl","rb")
nationality_clf = joblib.load(nationality_nv_model)




app = Flask(__name__)

@app.route('/')
def index():
	return render_template('index.html')

@app.route('/gender')
def gender():
	return render_template('gender.html')

@app.route('/api')
def api():
	return render_template('api_docs.html')

@app.route('/predict', methods=['GET','POST'])
def predict():
	

	# Receives the input query from form
	if request.method == 'POST':
		namequery = request.form['namequery']
		data = [namequery]

		vect = nationality_cv.transform(data).toarray()
		result = nationality_clf.predict(vect)	
	return render_template('index.html',name=namequery.upper(),prediction=result)

@app.route('/predict_gender', methods=['GET','POST'])
def predict_gender():
	

	# Receives the input query from form
	if request.method == 'POST':
		namequery = request.form['namequery']
		data = [namequery]

		vect = gender_cv.transform(data).toarray()
		result = gender_clf.predict(vect)	
	return render_template('gender.html',name=namequery.title(),prediction=result)


#Api
@app.route('/api/nationality/<string:name>')
def api_nationality(name):

	data = [name]
	
	vect = nationality_cv.transform(data).toarray()
	result = nationality_clf.predict(vect)

	return jsonify({"original name":name,"predicton":result[0]})

@app.route('/api/gender/<string:name>')
def api_gender(name):
	data= [name]

	vect = gender_cv.transform(data).toarray()
	cus_prediction = gender_clf.predict(vect)
	if cus_prediction == 0:
		result = 'Female'
	else:
		result = 'Male'  

	return jsonify({"original name":name,"predicton":result})

if __name__ == '__main__':
	app.run(debug=True)