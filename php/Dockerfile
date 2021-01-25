FROM php:7.4

WORKDIR /app

RUN apt-get update && apt-get install -y libxml2-dev git
RUN docker-php-ext-install soap
RUN curl -sS https://getcomposer.org/installer | php \
  && mv composer.phar /usr/local/bin/ \
  && ln -s /usr/local/bin/composer.phar /usr/local/bin/composer

COPY composer.* ./
RUN composer install --prefer-source --no-interaction

ENV PATH="~/.composer/vendor/bin:./vendor/bin:${PATH}"

COPY consumer.php .

CMD [ "php", "consumer.php" ]