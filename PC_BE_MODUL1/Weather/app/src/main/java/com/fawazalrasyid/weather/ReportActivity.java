package com.fawazalrasyid.weather;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.ProgressDialog;
import android.content.Intent;
import android.net.Uri;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

public class ReportActivity extends AppCompatActivity {

    ImageView btnSelect;
    Button btnUpload, btnBack;
    ImageView imageView;
    ProgressDialog progress;
    String response;
    String realPath;
    String UPLOAD_SERVER = "http://18.140.243.251/api/v1/weathers/report";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_report);
        btnSelect = (ImageView) findViewById(R.id.btnSelect);
        btnSelect.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(Intent.ACTION_GET_CONTENT);
                intent.setType("image/*");
                startActivityForResult(intent, 0);
            }
        });

        btnUpload = (Button) findViewById(R.id.btnUpload);
        btnUpload.setOnClickListener( new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ReportActivity.SendImage start_task = new ReportActivity.SendImage();
                start_task.execute();
            }
        });

        btnBack = (Button) findViewById(R.id.btnBack);
        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });
    }

    @SuppressLint("MissingSuperCall")
    @Override
    protected void onActivityResult(int reqCode, int resCode, Intent data) {
        if(resCode == Activity.RESULT_OK && data != null){

            btnSelect.setImageURI(data.getData());

            Uri uri = data.getData();

        }
    }

    public class SendImage extends AsyncTask<Void, Void, Void> {
        @Override
        protected void onPreExecute() {
            progress = new ProgressDialog(ReportActivity.this);
            progress.setTitle("Uploading....");
            progress.setMessage("Please wait until the process is finished");
            progress.setCancelable(false);
            progress.show();

        }

        @Override
        protected Void doInBackground(Void... params) {
            try {
                response = POST_Data(realPath);
                progress.dismiss();
            } catch (Exception e) {
                response = "Image was not uploaded!";
                progress.dismiss();
            }
            return null;
        }

        @Override
        protected void onPostExecute(Void result) {
        }
    }

    public String POST_Data(String filepath) throws Exception {
        HttpURLConnection connection = null;
        DataOutputStream outputStream = null;
        InputStream inputStream = null;
        String boundary =  "**"+Long.toString(System.currentTimeMillis())+"**";
        int bytesRead, bytesAvailable, bufferSize;
        byte[] buffer;
        String[] q = filepath.split("/");
        int idx = q.length - 1;
        File file = new File(filepath);
        FileInputStream fileInputStream = new FileInputStream(file);
        URL url = new URL(UPLOAD_SERVER);
        connection = (HttpURLConnection) url.openConnection();
        connection.setDoInput(true);
        connection.setDoOutput(true);
        connection.setUseCaches(false);
        connection.setRequestMethod("POST");
        connection.setRequestProperty("Connection", "Keep-Alive");
        connection.setRequestProperty("User-Agent", "Android Multipart HTTP Client 1.0");
        connection.setRequestProperty("Content-Type", "multipart/form-data; boundary="+boundary);
        outputStream = new DataOutputStream(connection.getOutputStream());
        outputStream.writeBytes("--" + boundary + "\r\n");
        outputStream.writeBytes("Content-Disposition: form-data; name=\"" + "img_upload" + "\"; filename=\"" + q[idx] +"\"" + "\r\n");
        outputStream.writeBytes("Content-Type: image/jpeg" + "\r\n");
        outputStream.writeBytes("Content-Transfer-Encoding: binary" + "\r\n");
        outputStream.writeBytes("\r\n");
        bytesAvailable = fileInputStream.available();
        bufferSize = Math.min(bytesAvailable, 1048576);
        buffer = new byte[bufferSize];
        bytesRead = fileInputStream.read(buffer, 0, bufferSize);
        while(bytesRead > 0) {
            outputStream.write(buffer, 0, bufferSize);
            bytesAvailable = fileInputStream.available();
            bufferSize = Math.min(bytesAvailable, 1048576);
            bytesRead = fileInputStream.read(buffer, 0, bufferSize);
        }
        outputStream.writeBytes("\r\n");
        outputStream.writeBytes("--" + boundary + "--" + "\r\n");
        inputStream = connection.getInputStream();
        int status = connection.getResponseCode();
        if (status == HttpURLConnection.HTTP_OK) {
            BufferedReader in = new BufferedReader(new InputStreamReader(connection.getInputStream()));
            String inputLine;
            StringBuffer response = new StringBuffer();
            while ((inputLine = in.readLine()) != null) {
                response.append(inputLine);
            }
            inputStream.close();
            connection.disconnect();
            fileInputStream.close();
            outputStream.flush();
            outputStream.close();
            return response.toString();
        } else {
            throw new Exception("Non ok response returned");
        }
    }
}
