const request = require('supertest');
const app = require('./index');
const { expect } = require('chai');

describe('GET /', () => {
  it('responds with 200 status and HTML content', (done) => {
    request(app)
      .get('/')
      .expect('Content-Type', /html/)
      .expect(200)
      .end((err, res) => {
        if (err) return done(err);
        expect(res.status).to.equal(200);
        expect(res.headers['content-type']).to.match(/html/);
        done();
      });
  });
});

describe('GET /haikus', () => {
  it('responds with JSON content and all haikus', (done) => {
    request(app)
      .get('/haikus')
      .expect('Content-Type', /json/)
      .expect(200)
      .end((err, res) => {
        if (err) return done(err);
        expect(res.status).to.equal(200);
        expect(res.headers['content-type']).to.match(/json/);
        expect(res.body).to.deep.equal({haikus: require('./haikus.json')});
        done();
      });
  });
});

describe('GET /nonexistent', () => {
  it('responds with 404 status and error message', (done) => {
    request(app)
      .get('/nonexistent')
      .expect('Content-Type', /html/)
      .expect(400)
      .end((err, res) => {
        if (err) return done(err);
        expect(res.status).to.equal(404);
        expect(res.headers['content-type']).to.match(/html/);
        expect(res.text).to.match(/Cannot GET \/nonexistent/);
        done();
      });
  });
});
