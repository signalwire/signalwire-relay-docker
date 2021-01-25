FROM python:3

RUN pip install signalwire

EXPOSE 5000

COPY consumer.py .

CMD [ "python", "./consumer.py" ]